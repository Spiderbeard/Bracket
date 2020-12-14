<template>
  <div class="home">
    <div class="home-text justify-content-center">
      <h2>Home</h2>
    </div>
    <div
      class="home-text d-flex justify-content-center"
      style="font-size: 14px;"
    >
      <p style="font-size:20px;">Welcome</p>
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
