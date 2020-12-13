<template>
  <div id="app" class="layout">
    <header id="nav" class="header-stripe">
      <router-link class="navigation" v-bind:to="{ name: 'home' }">Home</router-link>&nbsp;|&nbsp;
      <router-link class="navigation" v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
      <router-link class="navigation" v-bind:to="{ name: 'login' }" v-else>Login</router-link>
    </header>
    <router-view class="main"/>
    <div class="footer-stripe">
      <footer>
        <p> &copy; Bracketeers 2020 </p>
      </footer>
    </div>
  </div>
</template>

<style scoped>
.navigation {
    /* padding: 0.5em; */
    color:#3A506B;
    text-decoration: none;
}

.navigation:hover {
    color: #FCA311;
    text-decoration: underline;
}

.header-stripe {
  background-color: #E5E5E5;
  padding: 1em;
  width: 100%;
}

.footer-stripe {
  background-color: #E5E5E5;
  padding: 1em;
  width: 100%;
  /* bottom: 0; */
}

.layout {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.main {
  flex: 1;
}
</style>