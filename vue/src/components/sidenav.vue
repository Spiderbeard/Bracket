<template>
<div>
  <form action="">
    <main>
        <h2 class="header">Welcome to the tournament bracket generator!</h2><br/>
        <div class="nav-input-boxes">
          <label for="Title" style="padding-right: 5px;font-size: 18px;">Title: </label>
          <input type="text" placeholder="Enter Tournament Title" style="border: 1px solid black;"/>
        </div>
        <div class="nav-input-boxes">
          <label for="#ofthings" style="padding-right: 5px;font-size: 18px;">Number of participants:</label>
          <select v-model="selected" name="" id="">
          <option v-for="option in options" v-bind:key="option">
          {{ option }}
          </option>
          </select>
        </div>
      <div class="nav-input-boxes">
        <button type="submit" @click.prevent="updatePants">Submit</button>
      </div>
    </main>
  </form>
</div>
</template>

<script>
export default {
  data() {
    return {
      selected: "",
      options: [2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16],
    };
  },
  methods: {
    updatePants() {
      this.$store.commit("UPDATE_PARTICIPANTS", this.selected);
      this.$router.push("/tournament");
    },
  },
};
</script>

<style>
.header {
  display: flex;
  justify-content: center;
}

.nav-input-boxes {
  display: flex;
  justify-content: center;
  margin: 5px 0px 15px;
}
</style>
