<template>
  <div>
    <form action="">
      <main>
        <h2 class="header">Welcome to the tournament bracket generator!</h2>
        <br />
        <div class="nav-input-boxes">
          <!-- <label for="Title" style="padding-right: 5px;font-size: 18px;"
            >Title:
          </label> -->
          <input
            type="text"
            placeholder=" Enter Tournament Title"
            style="border: 1px solid black;"
            v-model="bracketName"
          />
        </div>
        <form action="">
          <div class="nav-input-boxes">
            <label for="#ofthings" style="padding-right: 5px;font-size: 18px;"
              >Number of participants:</label>
            <select v-model="selected" name="" id="" @change="checkForm">
              <option v-for="option in options" v-bind:key="option">
                {{ option }}
              </option>
            </select>
          </div>
          <div class="header">
          <!-- <p v-if="isSelected" @click.prevent="updatePants" style="display:hidden;"/> -->
          <p v-if="!isSelected" id="no-pants-text" style="display:none">
            * Please select a number of participants.
          </p>
          </div>
          <div class="nav-input-boxes" style="font-size: 16px;">
            <button v-if="isSelected" type="submit" @click.prevent="updatePants">Submit</button>
            <button v-else type="submit" @click.prevent="checkForm; showText()">Submit</button>
          </div>
        </form>
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
      isSelected: false,
      bracketName:''
    };
  },
  methods: {
    updatePants() {
      this.$store.commit("UPDATE_PARTICIPANTS", this.selected);
    // if(this.selected==="" ) {
      this.$store.commit('SET_BRACKET_NAME',this.bracketName)

    // }
    if(this.$store.state.token == ''){
      this.$router.push("/tournamentBase");
      } else {
      this.$router.push("/tournament")
      }  
    },

    checkForm() { 
      if(this.selected==="" || this.selected==null) {
        this.isSelected = false;
      } else {
        this.isSelected = true;
      }
    },

    showText() {
      let text = document.getElementById("no-pants-text");
      text.style.display = "block";
    }
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
  margin: 5px 0px 3%;
}

#no-pants-text {
  /* align-content: center;
  display: flex;
  justify-content: center; */
  color: #F38181;
  font-weight: bold;
}
</style>
