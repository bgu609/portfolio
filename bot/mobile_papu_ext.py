import discord
from discord.ext import commands
import asyncio
import threading

import dscdbot
from dscdbot import Timing
from dscdbot import Gamble
from dscdbot import Crawling
from dscdbot import Chase

Papu = commands.Bot(command_prefix='!')



def helpCall():
	helpMsg = discord.Embed(color=0xff00ff)
	helpMsg.set_author(name='파푸봇 사용법')
	#helpMsg.set_thumbnail(url=" ")
	helpMsg.add_field(name="대화형", value="`파푸봇 <조합어> 형식으로 입력`")
	helpMsg.add_field(name="<조합어> 목록", value="`사용법`")
	helpMsg.add_field(name="명령형", value="`!<명령어> 형식으로 입력`", inline=True)
	helpMsg.add_field(name="<명령어> 목록", value="`사용법    업데이트    연구소    연구소대기 <주기(분 단위)>    강화 <아이템> <확률> <횟수>    거점준비물    선박도감    생활재료    대포`", inline=True)
	#helpMsg.add_field(name="필드네임", value="필드값", inline=True)
	return helpMsg
"""
class Mul_thread:
	def set_data(self, sec): #초단위 타이밍 설정 (debug)
		self.sec = sec
	
	def retask(self): #멀티스레딩
		print(self.sec)
		print("task repeat")
		threading.Timer(self.sec, self.retask).start()
"""


@Papu.event
async def on_ready():
	print('파푸봇 기동') #debug console
	await Papu.change_presence(status=discord.Status.online, activity=discord.Game("파푸봇 일")) #디스코드 상태 설정

#대화형 동작
@Papu.event
async def on_message(message):
	msglist = message.content.split(' ')#
	 #특정 동작에 필요해서 일단 다시 가져옴
	msg = dscdbot.parse_Msg(message.content)
	#파싱 함수 자체는 현재로써 효율이 낮은 듯
	
	if msglist[0]=="!강화" and len(msglist)==3: #횟수 미표기 루트
		result = Gamble.per_Try(1, msglist[2])
		result_msg = "{}  ".format(msglist[1]) + str(result[0]) + str(result[1]) + "했다 푸`"
		await message.channel.send(result_msg)
			
	elif msg[0]=='!':
		await Papu.process_commands(message)
		
	else:
		if msg[:3]=="파푸봇":
			if len(msg)==3:
				#await message.channel.send(message.author.nick)
				await message.channel.send(message.author.mention + '   ' +  "`일하는 중이다 푸`")
			
			elif msg[3:6]=="사용법":
				help = helpCall() #embed 앞에 text 없는데 작동은 정상
				await message.channel.send(embed=help)
			
			else:
				await message.channel.send("`명령을 잘못 입력하신 것 같다 푸`")



#명령형 동작
@Papu.command() #debug용
async def 커맨드(ctx):
	await ctx.send("`커맨드 입력 정상작동 중`")

@Papu.command()
async def 사용법(ctx):
	help = helpCall()
	await ctx.send(embed=help)

@Papu.command()
async def 업데이트(ctx):
	List = Crawling.upnote(Crawling.kr_url)
	Key = list(List.keys())
	Value = list(List.values())
	
	update = discord.Embed(color=0x000000)
	update.set_author(name='******* 새 소식  *****************')
	update.set_thumbnail(url="https://cdn.discordapp.com/attachments/714496780712017980/723998298381353000/1592685034692.png")
	for i in range(0, len(Key)):
			update.add_field(name=Key[i], value=Value[i])
			
	await ctx.send(embed=update)

@Papu.command()
async def 연구소(ctx):
	List = Crawling.lab()
	Key = list(List.keys())
	Value = list(List.values())
	
	update = discord.Embed(color=0x000000)
	update.set_author(name='****** 연구소 소식  ***************')
	update.set_thumbnail(url="https://cdn.discordapp.com/attachments/714496780712017980/723998298381353000/1592685034692.png")
	for i in range(0, len(Key)):
			update.add_field(name=Key[i], value=Value[i])
			
	await ctx.send(embed=update)

@Papu.command()
async def 강화(ctx, item, prob, num):
	result = Gamble.per_Try(num, prob)
	message = "{}  ".format(item) + str(result[0]) + str(result[1]) + "했다 푸`"
	await ctx.send(message)
@강화.error
async def 강화_error(ctx, error):
	await ctx.send("`명령을 잘못 입력하신 것 같다 푸`")

@Papu.command()
async def 거점준비물(ctx):
	image = discord.Embed()
	image1 = discord.Embed()
	image2 = discord.Embed()
	image.set_author(name="다듬어진 석재", icon_url="https://cdn.discordapp.com/attachments/714496780712017980/716725747129122867/00004068.png")
	image1.set_author(name="철 주괴 30개", icon_url="https://cdn.discordapp.com/attachments/714496780712017980/716693169269506139/00004052.png")
	image1.set_footer(text="녹아내린 구리 조각 15개", icon_url="https://cdn.discordapp.com/attachments/714496780712017980/716693194385129502/00004057.png")
	image2.set_author(name="강철 주괴 100개", icon_url="https://cdn.discordapp.com/attachments/714496780712017980/716692839802601502/00004077.png")
	image2.set_footer(text="녹아내린 백금 조각 50개", icon_url="https://cdn.discordapp.com/attachments/714496780712017980/716693214341627955/00004257.png")
	await ctx.send(" ==== 성채 수리 ==== ", embed=image)
	await ctx.send(" ==== 철제 바리게이트 ==== ", embed=image1)
	await ctx.send(" ==== 강화 화염탑, 대신기전 ==== ", embed=image2)

@Papu.command()
async def 선박도감(ctx):
	await ctx.send("http://inven.co.kr/board/black/3584/43169")

@Papu.command()
async def 생활재료(ctx):
	rate = discord.Embed(color=0x008000)
	rate.set_author(name="일반 | 고급 | 특상 [비율]")
	rate.set_image(url="https://cdn.discordapp.com/attachments/714496780712017980/720297372672065546/i13601956785.jpg")
	rate.add_field(name="1. ", value="`일반 꽃 X 4 = 고급 꽃 | 일반 꽃 X 9 = 특상품 꽃`", inline=False)
	rate.add_field(name="2. ", value="`일반 곡물 X 3 = 고급 곡물 | 일반 곡물 X 6 = 특상품 곡물`", inline=False)
	rate.add_field(name="3. ", value="`일반 채소 X 2 = 고급 채소 | 일반 채소 X 8 = 특상품 채소`", inline=False)
	rate.add_field(name="4. ", value="`일반 과일 X 4 = 고급 과일 | 일반 과일 X 9 = 특상품 과일`", inline=False)
	rate.add_field(name="5. ", value="`일반 벌꿀 X 2 = 고급 벌꿀 | 일반 벌꿀 X 3 = 특상품 벌꿀`", inline=False)
	rate.add_field(name="6. ", value="`일반 약초 X 3 = 고급 약초 | 일반 꽃 X 6 = 특상품 약초`", inline=False)
	rate.add_field(name="7. ", value="`일반 버섯 X 2 = 고급 버섯 | 일반 버섯 X 3 = 특상품 버섯`", inline=False)
	
	#await ctx.send("https://cdn.discordapp.com/attachments/714496780712017980/720297372672065546/i13601956785.jpg")
	await ctx.send(embed=rate)

@Papu.command()
async def 대포(ctx):
	await ctx.send("https://cdn.discordapp.com/attachments/714496780712017980/720297471296929792/43e00bd23a32da5d.jpg")

@Papu.command()
async def 연구소대기(ctx, min):
	await ctx.send(ctx.author.mention + "연구소 업데이트 대기, {}분 간격으로 확인한다 푸".format(min))
	waiting = Crawling()
	waiting.set_data(int(min))
	waiting.set_List()
	waiting.retask()
	if waiting.Past_List!=waiting.List:
		List = waiting.List
		Key = list(List.keys())
		Value = list(List.values())
		
		update = discord.Embed(color=0x000000)
		update.set_author(name='****** 연구소 소식  ***************')
		update.set_thumbnail(url="https://cdn.discordapp.com/attachments/714496780712017980/723998298381353000/1592685034692.png")
		for i in range(0, len(Key)):
				update.add_field(name=Key[i], value=Value[i])
		
		await ctx.send(ctx.author.mention, embed=update)
@연구소대기.error
async def 연구소대기_error(ctx, error):
	await ctx.send("`명령을 잘못 입력하신 것 같다 푸`")



Papu.run("토큰은 비공개") # token없이 running 불가