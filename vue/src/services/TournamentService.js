import axios from 'axios';


export default{

    GetTournaments(id){
        return axios.get('/api/Tournament',id);
    },

    AddTournament(Tournament){
        return axios.post('/api/Tournament',Tournament);
    }
}