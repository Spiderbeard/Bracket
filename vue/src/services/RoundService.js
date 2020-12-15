import axios from 'axios';


export default{

    GetRound(id){
        return axios.get('/api/Round',id)
    },

    addRound(round){
        return axios.post('/api/Round',round)

    }
}