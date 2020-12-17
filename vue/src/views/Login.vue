<template>
  <div id="login" class="text-center">
    <div class="well">
    <form class="form-signin login-page-margin" @submit.prevent="login">
      <h1 class="h3 mb-3 font-weight-normal">Please Sign In</h1>
      <div
        class="no-pants-text"
        v-if="invalidCredentials"
        @click.prevent="showText()"
      >Invalid username and password!</div>
      <div class="login-vis-update">
      <label for="username" class="sr-only ">Username</label>
      <input
        type="text"
        id="username"
        class="form-control"
        placeholder="Username"
        v-model="user.username"
        required
        autofocus
      />

      <label for="password" class="sr-only">Password</label>     
      <input
        type="password"
        id="password"
        class="form-control"
        placeholder="Password"
        v-model="user.password"
        required
      />
      </div>
      <div class="button-margins">
      <router-link :to="{ name: 'register' }">Need an account? </router-link>
      <button type="submit" class="login-button btn btn-lg btn-primary btn-block">Sign in</button>
      </div>
    </form>
          <div
        class="you-did-good-text"
        v-if="this.$route.query.registration"
      >Thank you for registering, please sign in.</div>
    </div>
  </div>
</template>

<script>
require("@/css/style.css");
import authService from "../services/AuthService";

export default {
  name: "login",
  components: {},
  data() {
    return {
      user: {
        username: "",
        password: "",
        emailAddress:""
      },
      invalidCredentials: false
    };
  },
  methods: {
    login() {
      authService
        .login(this.user)
        .then(response => {
          if (response.status == 200) {
            this.$store.commit("SET_AUTH_TOKEN", response.data.token);
            this.$store.commit("SET_USER", response.data.user);
            this.$router.push("/");
          }
        })
        .catch(error => {
          const response = error.response;

          if (response.status === 401) {
            this.invalidCredentials = true;
          }
        });
    },

    showText() {
      let text = document.getElementById("no-pants-text");
      text.style.display = "block";
    }
  }
};
</script>

<style>
.login-page-margin {
  margin-top: 5%;
}

.alert-adjustment {
  display: flex;
  justify-content: center;
}

.no-pants-text {
  color: #F38181;
  font-weight: bold;
  margin-bottom: 2%;
  background-color: #FBDADA;
  width: 20%;
  height: auto;
  padding: 5Px;
  border-radius: 5px;
  border: 1px solid  #F38181;
  margin-left: 40%;
}

.you-did-good-text {
  color: #91D384;
  font-weight: bold;
  margin-bottom: 2%;
  background-color: #E0FFDA;
  width: 20%;
  height: auto;
  padding: 5Px;
  border-radius: 5px;
  border: 1px solid  #91D384;
  margin-left: 40%;
  animation: hide 1s linear 2s 1 forwards;
}

@keyframes hide {
  to {
    opacity: 0;
  }
}

/* .page-margin {
  margin-top: 2%;
}

.login-button {
  margin: 2% 15px;
}

.login-vis-update {
  margin: 0% 20%;
  border: 1.5px solid #CFCFCF;
  border-radius: 5px;
} */
</style>