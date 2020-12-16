import axios from 'axios';


export default{

    GetTournaments(id){
        return axios.get('/api/Tournaments',id);
    },

    AddTournament(Tournament){
        return axios.post('/api/Tournaments',Tournament);
    }
}