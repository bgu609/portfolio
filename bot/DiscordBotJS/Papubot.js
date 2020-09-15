const Discord = require('discord.js'); // discord.js 모듈 사용
const Config = require('./config.json'); // config.json 사용
const Bot = new Discord.Client(); // Bot Client 객체 생성

Bot.on('ready', () => {
    console.log(`Login as ${Bot.user.tag}`);
}); // 객체.이벤트 리스너(이벤트, callback 함수)




Bot.login(Config.token_piece_1 + Config.token_piece_2 + Config.token_piece_3); // 봇 로그인