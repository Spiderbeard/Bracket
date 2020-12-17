import axios from 'axios';


export default{

    AddParticipants(victims){
        return axios.post('/api/Participants',victims)
    }
    
}