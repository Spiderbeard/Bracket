import axios from 'axios';

export default {
    saveMatch(match){
        return axios.post('/api/Match',match)
    }

}