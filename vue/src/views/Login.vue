<template>
  <div id="login" class="text-center">
    <form class="form-signin page-margin " @submit.prevent="login">
      <h1 class="h3 mb-3 font-weight-normal">Please Sign In</h1>
      <div
        class="alert alert-danger"
        role="alert"
        v-if="invalidCredentials"
      >Invalid username and password!</div>
      <div
        class="alert alert-success"
        role="alert"
        v-if="this.$route.query.registration"
      >Thank you for registering, please sign in.</div>
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
    }
  }
};
</script>

<style>
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