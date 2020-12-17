import axios from 'axios';


export default{

    addRound(rounds){
        return axios.post('/api/Rounds',rounds)

    }
}