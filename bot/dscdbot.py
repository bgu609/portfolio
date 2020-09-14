from discord.ext import commands
import random
import time
import threading
from urllib.request import urlopen
from bs4 import BeautifulSoup
#디스코드 봇 동작 기능 모음



#시간형 동작
class Timing:
	time_struct = time.localtime(time.time()) #기본 객체
#>>> time.struct_time(tm_year=연, tm_mon=월, tm_mday=일, tm_hour=시, tm_min=분, tm_sec=초, tm_wday=0월~6일, tm_yday=139경과한 일수, tm_isdst=0서머타임 여부)
	
	time_ymd = time.strftime('%Y-%m-%d', time.localtime(time.time()))
	
	def cmin(min):
		sec = int(min) * 60
		return sec
	
	def chour(hour):
		sec = int(hour) * 3600
		return sec
	
	def instrument(sec):
		print("시작")
		past_hour = Timing.time_struct.tm_hour
		past_min = Timing.time_struct.tm_min
		print(past_hour, past_min)
		
		time.sleep(sec)
	
		n_time_struct = time.localtime(time.time())
		print(n_time_struct.tm_hour, n_time_struct.tm_min)



#확률
class Gamble:
	#percentage 컨버터
	def convert(probability): # probability = str 타입
		num = ''.join(probability.split('%'))
		div_num = num.split('.')
		#div_num = ''.join(probability.split('%')).split('.')
		
		if len(div_num)==2: #입력값이 실수형
			select = int(float(num)*(10**len(div_num[1])))
			order = 100*(10**len(div_num[1]))
		else: #입력값이 실수형이 아닐 때 (정수형)
			select = int(num)
			order = 100
		
		slot = [select, order] # 정수형 n/m 확률 [n, m]
		#print(slot) # debug
		return slot
	
	#n/m 확률 발생기
	def get(slot): # slot=[정수형 유효숫자, order] 형태의 리스트
		gain=random.randrange(0,slot[1])
		if gain<slot[0]: # 성공 범위
			return 1
		else: # 실패 범위
			return 0
	
	#percentage 확률 발생기
	def per(probability):
		return Gamble.get(Gamble.convert(probability))
	
	#num번 확률 (성공시 중단)
	def per_Try(num, probability):
		for i in range(0, int(num)):
			result = Gamble.per(probability)
			i+=1
			if result==1:
				result_list = ["`{}트에 ".format(i), "성공"]
				return result_list
				
		if result==0:
			result_list = ["`{}트 ".format(i), "실패"]
		else:
			result_list["`error", "error"]
		
		return result_list

#디스코드 메시지 파싱
def parse_Msg(message_content):
	msglist = message_content.split(' ')
	msg = ''.join(msglist)
	return msg



#웹 크롤링
class Crawling:
	kr_url="https://www.kr.playblackdesert.com/News/Notice"
	lab_url="https://www.global-lab.playblackdesert.com/News/Notice"
	
	def set_data(self, min): #분단위 타이밍 설정 (debug)
		self.min = Timing.cmin(min)
		self.i = 0
	
	def set_List(self): #업데이트 목록 초기화
		self.Past_List = Crawling.upnote(Crawling.lab_url)
	
	def retask(self): #멀티스레딩 (연구소 전용)
		repeat = threading.Timer(self.min, self.retask)
		repeat.start() #타이머 시작
		self.Str = str() #명령 전송영역
		self.List = Crawling.upnote(Crawling.lab_url) #최신 업데이트
		
		#이전-다음 시간대 최신 업데이트 비교
		if self.Past_List == self.List:
			print("{} same".format(self.i)) #debug
			self.i += 1
			if self.i == 3:
				self.Past_List = {0:0} #다음 크롤링이 이전과 다른 상황 연출
		else:
			print("{} difference".format(self.i)) #debug
			commands.Bot(command_prefix='!').process_commands(연구소(ctx))
			repeat.cancel() #타이머 정지
	
	def news(): #상단 헤드에 등록된 업데이트만 표시
		#크롤링 링크(공식 홈페이지)
		html = urlopen(Crawling.kr_url)
		bsObject = BeautifulSoup(html, "html.parser")
		
		newsNumList = list() #{최신 업데이트 번호}
		newsList = {} #{업데이트 번호:타이틀}
		updateList = {} #{업데이트 번호:링크}
		outputList = {} #반환용 딕셔너리 {타이틀:링크}
		
		#최신목록 newsList, newsNumList
		newsObj = bsObject.find("div",{"class":"top_news_wrap"})
		for link in newsObj.findAll('a'):
			newsText=link.find("span") # bs4.element.Tag 타입
			newsNum=link.get('data-boardno') # str 타입
			newsList[newsNum] = newsText.text.strip() # str 타입
			newsNumList.append(newsNum)
		
		#전체목록 updateList
		updateObj = bsObject.find("div", {"class":"thumb_nail_area"})
		for link in updateObj.findAll('a'):
			updateList[link.get('data-boardno')] = link.get('href')
		
		#최신뉴스
		for i in newsNumList:
			outputList[newsList[i]] = updateList[i] #타이틀:링크
		
		#print(outputList) #debug
		return outputList
	
	def upnote(url): #icon_new가 존재하는 업데이트 표시
		#크롤링 링크(공식 홈페이지)
		html = urlopen(url)
		bsObject = BeautifulSoup(html, "html.parser")
		
		updateNumList = list() #업데이트 번호 리스트
		updateNew = {} #{업데이트 번호:icon_new}
		updateNote = {} #{업데이트 번호:타이틀}
		updateLink = {} #{업데이트 번호:링크}
		outputList = {} #반환용 딕셔너리 {타이틀:링크}
		
		#전체목록 updateNote,Link
		updateObj = bsObject.find("div", {"class":"thumb_nail_area"})
		for link in updateObj.findAll('a'):
			updateNum = link.get('data-boardno')
			updateNew[updateNum] = link.find('span', {"class":"icon_new"})
			updateNote[updateNum] = link.find('span', {"class":"desc"}).text.strip()
			updateLink[updateNum] = link.get('href')
			updateNumList.append(updateNum)
		
		#최신 업데이트
		for i in updateNumList:
			if updateNew[i] is not None:
				outputList[updateNote[i]] = updateLink[i] #타이틀:링크
		
		return outputList
	
	def lab():
		#크롤링 링크(연구소)
		html = urlopen(Crawling.lab_url)
		bsObject = BeautifulSoup(html, "html.parser")
		
		newsNumList = list() #{뉴스 업데이트 번호}
		newsList = {} #{뉴스 업데이트 번호:타이틀}
		#updateNumList = list() #업데이트 번호 리스트
		#updateNew = {} #{업데이트 번호:icon_new}
		#updateNote = {} #{업데이트 번호:타이틀}
		updateLink = {} #{업데이트 번호:링크}
		outputList = {} #반환용 딕셔너리 {타이틀:링크}
		
		#최신목록 newsList, newsNumList
		newsObj = bsObject.find("div",{"class":"top_news_wrap"})
		link = newsObj.find('a')
		newsText=link.find("span") # bs4.element.Tag 타입
		newsNum=link.get('data-boardno') # str 타입
		newsList[newsNum] = newsText.text.strip() # str 타입
		newsNumList.append(newsNum)
		
		#전체목록 updateLink
		updateObj = bsObject.find("div", {"class":"thumb_nail_area"})
		for link in updateObj.findAll('a'):
			updateNum = link.get('data-boardno')
			#updateNew[updateNum] = link.find('span', {"class":"icon_new"})
			#updateNote[updateNum] = link.find('span', {"class":"desc"}).text.strip()
			updateLink[updateNum] = link.get('href')
			#updateNumList.append(updateNum)
		
		#최신 업데이트
		#for i in updateNumList:
		#	if updateNew[i] is not None:
		#		outputList[updateNote[i]] = updateLink[i] #타이틀:링크
		
		#최신 뉴스
		for i in newsNumList:
			outputList[newsList[i]] = updateLink[i] #타이틀:링크
		
		return outputList



#적대 추적
class Chase:
	txt = "ChaseSheet.txt"
	
	def reset():
		#쓰기모드로 시트 리셋
		with open(Chase.txt, "w") as file:
			file.write("chaseMod=0\n")
			file.write("chaseTarget=\n")
			file.write("channel=\n")
	
	def set_Mod(mod):
		data = Chase.sheet()
		#추적모드 수정
		with open(Chase.txt, "w") as file:
			data[0] = "chaseMod={}".format(str(mod))
			
			#전체 덮어쓰기
			for i in range(0, len(data)):
				file.write(data[i] + "\n")
	
	def set_Target(name):
		data = Chase.sheet()
		#추적타겟 수정
		with open(Chase.txt, "w") as file:
			data[1] = "chaseTarget={}".format(str(name))
			
			#전체 덮어쓰기
			for i in range(0, len(data)):
				file.write(data[i] + "\n")
	
	def set_Channel(ch_num):
		data = Chase.sheet()
		#추적채널
		with open(Chase.txt, "w") as file:
			data[2] = "channel={}".format(str(ch_num))
			
			#전체 덮어쓰기
			for i in range(0, len(data)):
				file.write(data[i] + "\n")
	
	def sheet():
		#시트 읽기 모드
		with open(Chase.txt, "r") as file:
			data=file.read().split() #라인 단위로 데이터 리스트 생성
			print(data) #(debug)
			
			chaseMod = data[0].split('=')
			chaseTarget = data[1].split('=')
			chaseChannel = data[2].split('=')
			
			#(debug)
			print("모드 : " + chaseMod[1])
			print("타겟 : " + chaseTarget[1])
			print("채널 : " + chaseChannel[1])
			
			return data