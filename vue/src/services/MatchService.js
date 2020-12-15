import axios from 'axios';

export default {
    saveMatch(match){
        return axios.post('/api/Match',match)
    },
    getMatch(id){
        return axios.get('/api/Match/',id)
    }
}