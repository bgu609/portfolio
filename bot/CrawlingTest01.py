from CrawlingTest00 import *



####################################################
# 비동기 task 함수
#
#
# 1차 비동기 (page)
async def async_gTBL(last):
    fts = [asyncio.ensure_future(async_page(DB, page)) for page in reversed(range(1, 1+last))]
    await asyncio.gather(*fts)
# 2차 비동기 (guild)
async def async_page(self, page):
    g_dic = await get_guild(page, loop)
    print("get page ", page)

    fts = [asyncio.ensure_future(async_guild(self, key, value)) for key, value in g_dic.items()]
    await asyncio.gather(*fts)
# 비동기 sql 명령
async def async_guild(self, key, value):
    global gworknum #함수 내에서 전역변수 접근
    
    self.sql(f"INSERT INTO guildTBL (Guild, Begin) VALUES('{key}', '{value}')")
    self.con.commit()

    gworknum += 1
    print("guild : ", gworknum)
#
#
# 3차 비동기 (member)
async def async_mTBL(self, viewer):
    fts = [asyncio.ensure_future(async_member(self, List[0])) for List in viewer]
    await asyncio.gather(*fts)
#비동기 sql 명령
async def async_member(self, title):
    global mworknum #함수 내에서 전역변수 접근
    print(f"get {title} member...")
    m_dic = await get_member(title, loop)
    tuple = ()
    
    for key, value in m_dic.items():
        if type(key) == type(tuple):
            self.sql(f"UPDATE guildTBL SET Rear='{today}', Count='{value}' WHERE Guild='{title}'")
        else:
            self.sql(f"INSERT INTO memberTBL(Link, Name, Guild, Front, Rear) VALUES('{value}', '{key}', '{title}', '{today}', '{today}')")
    self.con.commit()
    
    mworknum += 1
    print(mworknum, f" : get member of {title} complete")
#
#
####################################################



####################################################
# table 초기화
def DB_reset(self):
    try:
        self.drop("guildTBL")
        self.drop("memberTBL")
        self.drop("logTBL")

        self.create("guildTBL", "Guild TEXT, Begin TEXT, Rear TEXT, Count TEXT") #이전 테이블 소거 후 새로 생성
        self.create("memberTBL", "Link TEXT, Name TEXT, Guild TEXT, Front TEXT, Rear TEXT") #이전 테이블 소거 후 새로 생성
        self.create("logTBL", "Release TEXT, Renewal TEXT") #이전 테이블 소거 후 새로 생성
    except:
        self.create("guildTBL", "Guild TEXT, Begin TEXT, Rear TEXT, Count TEXT") #이전 테이블 소거 후 새로 생성
        self.create("memberTBL", "Link TEXT, Name TEXT, Guild TEXT, Front TEXT, Rear TEXT") #이전 테이블 소거 후 새로 생성
        self.create("logTBL", "Release TEXT, Renewal TEXT") #이전 테이블 소거 후 새로 생성
#
# 최초 data setting
def DB_init_set(self, loop):
    last = page_check()
    print("last page : ", last)

    loop.run_until_complete(async_gTBL(last))
    loop.close
    
    view = self.read_all("guildTBL")
    scale = 1000
    limit = len(view)//scale + 1
    
    for idx in range(0, limit):
        if idx == limit:
            viewer = view[(idx*scale):]
        else:
            viewer = view[(idx*scale):((idx+1)*scale)]
        print("viewer length ", len(viewer))
        loop.run_until_complete(async_mTBL(self, viewer))
        loop.close
#
####################################################



####################################################
# 메인 함수
if __name__ == "__main__":
    startp = time.time()
    today = time.strftime('%Y-%m-%d', time.localtime(time.time()))
    gworknum = 0
    mworknum = 0

    route = 0
    DB_name = "CrTest" + time.strftime('%m%d', time.localtime(time.time())) #현재 날짜로 DB이름 결정
    DB = SQL(route, DB_name)
    print("경로 : ", DB.DB_route)

    loop = asyncio.get_event_loop()
    DB_reset(DB)
    DB_init_set(DB, loop)
    
    DB.sql(f"INSERT INTO logTBL(Release, Renewal) VALUES('{today}', '{today}')")
    
    DB.con.commit()
    DB.con.close()

    endp = time.time()
    print("{}초 걸렸습니다.".format(endp - startp))
#
####################################################