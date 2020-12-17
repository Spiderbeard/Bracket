import axios from 'axios';


export default{

    AddRounds(rounds){
        return axios.post('/api/Rounds',rounds)

    }
}