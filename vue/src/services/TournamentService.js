import axios from 'axios';


export default{

    GetTournaments(Organizerid){
        return axios.get(`/api/Tournaments/${Organizerid}`);
    },

    AddTournament(Tournament){
        return axios.post('/api/Tournaments',Tournament);
    },
    
    
}