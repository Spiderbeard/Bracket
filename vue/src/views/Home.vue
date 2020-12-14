<template>
  <div class="home">
    <div class="home-text">
      <h2>Home</h2>
      <h4>Welcome to the Bracket Builder 3000</h4>
    </div>

    <sidenav />
  </div>
</template>

<script>
import sidenav from "@/components/sidenav";

export default {
  components: { sidenav },
  name: "home",

  created() {
    this.$store.commit("UPDATE_PARTICIPANTS", 0);
  },
};
</script>

<style>
.home {
  margin-left: 20px;
}

.home-text {
  display: flex;
  justify-content: flex-start;
}

p {
  color: gray;
}
</style>
