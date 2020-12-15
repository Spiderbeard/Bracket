import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

/*
 * The authorization header is set for axios when you login but what happens when you come back or
 * the page is refreshed. When that happens you need to check for the token in local storage and if it
 * exists you should set the header so that it will be attached to each request
 */
const currentToken = localStorage.getItem('token')
const currentUser = JSON.parse(localStorage.getItem('user'));
const initialPants=0;
const initialParticipants = [];


if(currentToken != null) {
  axios.defaults.headers.common['Authorization'] = `Bearer ${currentToken}`;
}

export default new Vuex.Store({
  state: {
    token: currentToken || '',
    user: currentUser || {},
    numberOfParticipants: initialPants,
    Participants: initialParticipants,
    ActiveBracket: {
      name:'',
      teams: [],
    },
    match: {
      MatchNumber: 0,
      isactive: false,
      scoreTeam1: 0,
      socreTeam2: 0,
      team1winner: false,
      team2winner: false,
      roundId: 0,
      matchId: 0,
      Participants1: {
        participantId: 0,
        name: '',
        isactive: false

      },
      Participants2: {
        participantId: 0,
        name: '',
        isactive: false

      },
      matchInfo:[{}]

    }
  },
  mutations: {
    SET_AUTH_TOKEN(state, token) {
      state.token = token;
      localStorage.setItem('token', token);
      axios.defaults.headers.common['Authorization'] = `Bearer ${token}`
    },
    SET_USER(state, user) {
      state.user = user;
      localStorage.setItem('user',JSON.stringify(user));
    },
    LOGOUT(state) {
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      state.token = '';
      state.user = {};
      axios.defaults.headers.common = {};
    },
    UPDATE_PARTICIPANTS(state,numberOfPants){
      if( numberOfPants == 0){
        state.Participants = []; 
      } else {
        for(let i = 0; i < numberOfPants ; i++){
          let Team = {
            id: "Team "+ (i+1),
            name:"",
            edit:false
          };
          state.Participants.push(Team);
        }
      }
    },
    SET_BRACKET_NAME(state,name){
      state.ActiveBracket.name = name;
    },
    SET_BRACKET_PARTICIPANTS(state,teamsArray){
      state.ActiveBracket.team=teamsArray;
    }

  }
})
