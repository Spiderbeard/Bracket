<template>
  <div class="tournament-margins">
    <div class="bracketVisualizer">
      <div
        id="roundHeaders"
        class="headers d-flex flex-row justify-content-between pl-3 pr-3"
      >
        <h3
          v-for="Round in this.getRoundTitles"
          v-bind:key="Round"
          v-bind:class="{}"
        >
          {{ Round }}
        </h3>
        <h3>CHAMPION</h3>
      </div>
      <div
        id="actualBracket"
        class="d-flex flex-row align-items-stretch pl-3 pr-3"
      >
        <div
          id="Round1"
          class="matches round-1 d-flex flex-column justify-content-around"
        >
          <div
            class="match  border border-dark team-block"
            v-for="(match, index) in this.constuctMatches"
            v-bind:key="match.index"
          >
            <div class="team-top border-bottom border-dark">
              <span>
                <div v-show="teamsArray[index].edit == false">
                  <label
                    class="team-input"
                    @click="teamsArray[index].edit = true"
                  >
                    {{
                      teamsArray[index].name == ""
                        ? teamsArray[index].id
                        : teamsArray[index].name
                    }}
                  </label>
                </div>
                <input
                  class="input-box"
                  v-show="teamsArray[index].edit == true"
                  v-model="teamsArray[index].name"
                  v-on:blur="teamsArray[index].edit = false"
                  @keyup.enter="teamsArray[index].edit = false"
                />
              </span>
            </div>

            <div v-if="isLastOddElement(index)" class="team-bottom">
              <!-- <input
                
                  type="text" v-model="team[$store.state.Participants.length - index - 1]"
                  :placeholder="[
                    [
                      $store.state.Participants[
                        $store.state.Participants.length - index - 1
                      ].id,
                    ],
                  ]"
                />
                -->
              <span>
                <div
                  v-show="
                    teamsArray[teamsArray.length - index - 1].edit == false
                  "
                >
                  <label
                    class="team-input"
                    @click="
                      teamsArray[teamsArray.length - index - 1].edit = true
                    "
                  >
                    {{
                      teamsArray[teamsArray.length - index - 1].name == ""
                        ? teamsArray[teamsArray.length - index - 1].id
                        : teamsArray[teamsArray.length - index - 1].name
                    }}
                  </label>
                </div>
                <input
                  class="input-box"
                  v-show="
                    teamsArray[teamsArray.length - index - 1].edit == true
                  "
                  v-model="teamsArray[teamsArray.length - index - 1].name"
                  v-on:blur="
                    teamsArray[teamsArray.length - index - 1].edit = false;
                    $emit('update');
                  "
                  @keyup.enter="
                    teamsArray[teamsArray.length - index - 1].edit = false;
                    $emit('update');
                  "
                />
              </span>
            </div>
          </div>
        </div>
        <div
          id="yep"
          v-if="teamsArray.length > 2"
          class="d-flex flex-column justify-content-around  "
        >
          <div
            v-for="round in this.round2Matches"
            v-bind:key="round.id"
            class="d-flex flex-column align-self-stetch  "
            id="sp"
          >
            <!-- <div>
              <img
                src="../assets/bracket.png"
                class="img-fluid pt-4 pb-4"
                alt=""
              />  </div>
              -->
            <fork round="two" roundline="top" />
          </div>
        </div>
        <div
          v-if="someRandomMethod() > 1"
          class="round-2 d-flex flex-column justify-content-around"
        >
          <div
            class="matches w-100"
            v-for="(match, index) in this.round2Matches"
            v-bind:key="index"
          >
            <div class="match border border-dark w-100 ">
              <div class="team-top border-bottom border-dark ">
                <span>Winner of Match {{ index + 1 + index }}</span>
              </div>
              <div class="team-botom ">
                <span v-if="round2Bys(index)"
                  >Winner of Match {{ index + 2 + index }}</span
                >
              </div>
            </div>
          </div>
        </div>
        <div
          id="yep1"
          v-if="round2Matches.length > 1"
          class="d-flex flex-column justify-content-around "
        >
          <div
            v-for="round in this.round3Matches"
            v-bind:key="round.id"
            class="d-flex flex-column justify-content-center align-self-stretch "
            id="sp2"
          >
            <!-- <div>
              <img
                src="../assets/bracket.png"
                class="img-fluid pt-4 pb-4"
                alt=""
              />
            </div> -->
            <fork round="three" />
          </div>
        </div>
        <div
          v-if="someRandomMethod() > 2"
          class="matches round-3 d-flex flex-column justify-content-around "
        >
          <div
            class="matchesround3 w-100"
            v-for="(match, index) in this.round3Matches"
            v-bind:key="index"
          >
            <div
              class="match border border-dark w-100 d-flex flex-column justify-content-between"
            >
              <div class="team-top border-bottom border-dark ">
                <span
                  >Winner of Match
                  {{ round2Matches.length + index + 4 + index }}
                </span>
              </div>
              <div class="team-botom ">
                <span v-if="round3Bys(index)"
                  >Winner of Match
                  {{ round2Matches.length + index + 5 + index }}
                </span>
              </div>
            </div>
          </div>
        </div>
        <div
          id="yep2"
          v-if="round4Matches.length === 1"
          class="d-flex flex-column justify-content-center "
        >
          <div
            v-for="round in this.round4Matches"
            v-bind:key="round.id"
            class="d-flex flex-column justify-content-center "
            id="sp3"
          >
            <!-- <img src="../assets/bracket.png" class=" pt-4 pb-4" alt="" /> -->
            <fork round="four" />
          </div>
        </div>
        <div
          v-if="someRandomMethod() > 3"
          class="matches round-4 d-flex flex-colum justify-content-around"
        >
          <div
            class="matches w-100 d-flex flex-column justify-content-center"
            v-for="(match, index) in this.round4Matches"
            v-bind:key="index"
          >
            <div class="match border border-dark w-100">
              <div class="team-top border-bottom border-dark">
                <span
                  >Winner of Match {{ constuctMatches.length * 2 - 2 }}</span
                >
              </div>
              <div class="team-botom ">
                <span
                  >Winner of Match {{ constuctMatches.length * 2 - 1 }}</span
                >
              </div>
            </div>
          </div>
        </div>
        <div
          id="yep3"
          class="d-flex flex-column align-self-stretch justify-content-center "
        >
          <div
            class="d-flex flex-column justify-content-center align-items-stretch "
            id="sp"
          >
            <champion-line class="d-flex " />
          </div>
        </div>
        <div class="CHAMPION d-flex flex-column justify-content-center">
          <div
            class="border border-dark d-flex flex-column justify-content-center"
          >
            <span class="champion">Winner</span>
          </div>
        </div>
      </div>
    </div>
    <div class="motherFuckingButtons">
      <div class="button-margin">
        <button v-on:click="shuffleStore">Randomize</button>
      </div>
      <div class="button-margin"><button>Add Teams</button></div>
      <div class="button-margin">
        <button v-on:click="sendThemHome">Generate New Bracket</button>
      </div>
    </div>
  </div>
</template>

<script>
require("@/css/style.css");
import fork from "@/components/fork";
import HalfFork from "@/components/HalfFork";
import ChampionLine from "./ChampionLine.vue";

export default {
  components: {
    fork,
    // eslint-disable-next-line vue/no-unused-components
    HalfFork,
    ChampionLine,
  },
  created() {
    this.nextRoundMatches();
  },
  data() {
    return {
      numberOfRounds: this.getNumberOfRounds,
      team: [],
      round2Matches: [],
      round3Matches: [],
      round4Matches: [],
      teamsArray: this.$store.state.Participants,
      editedTodo: null,
      whatever: false,
      forkline: {
        round: "",
        line: "",
      },
    };
  },
  computed: {
    getNumberOfRounds() {
      let output = 0;
      let numberOfPants = this.$store.state.Participants.length;
      if (numberOfPants == 2) {
        output = 1;
      } else if (numberOfPants == 4 || numberOfPants == 3) {
        output = 2;
      } else if (numberOfPants > 4 && numberOfPants < 9) {
        output = 3;
      } else {
        output = 4;
      }
      return output;
    },
    getRoundTitles() {
      let output = [];
      for (let i = 1; i <= this.getNumberOfRounds; i++) {
        output.push("Round " + i);
      }
      return output;
    },
    constuctMatches() {
      let output = [];
      let matchUp = {};
      let length = this.$store.state.Participants.length;
      length /= 2;
      for (let i = 0; i < length; i++) {
        output.push(matchUp);
      }
      return output;
    },

    hasOddPants() {
      return this.$store.state.Participants.length % 2 == 1 ? true : false;
    },
    isEditting() {
      return true;
    },
  },
  methods: {
    isLastOddElement(index) {
      if (this.hasOddPants && index === this.constuctMatches.length - 1) {
        return false;
      }
      return true;
    },
    round2Bys(index) {
      if (
        (this.teamsArray.length === 5 ||
          this.teamsArray.length === 6 ||
          this.teamsArray.length === 9 ||
          this.teamsArray.length === 10 ||
          this.teamsArray.length === 13 ||
          this.teamsArray.length === 14) &&
        this.round2Matches.length - 1 === index
      ) {
        return false;
      }
      return true;
    },
    round3Bys(index) {
      if (
        this.teamsArray.length >= 9 &&
        this.teamsArray.length <= 12 &&
        this.round3Matches.length - 1 === index
      ) {
        this.whatever == true;
        return false;
      }
      return true;
    },
    shuffle(array) {
      array.sort(() => Math.random() - 0.5);
    },
    shuffleStore() {
      this.shuffle(this.team);
      this.shuffle(this.team);
      this.shuffle(this.$store.state.Participants);
    },
    editTodo: function(todo) {
      this.editedTodo = todo;
    },
    addTeams() {},
    someRandomMethod() {
      let output = 0;
      let length = this.$store.state.Participants.length;
      if (length % 2 === 1) {
        length--;
      }
      do {
        length /= 2;
        output++;
      } while (length >= 1);
      return output;
    },
    nextRoundMatches() {
      let fullLength = this.teamsArray.length;
      if (fullLength >= 13) {
        this.round2Matches.push("", "", "", "");
      } else if (fullLength < 13 && fullLength >= 9) {
        this.round2Matches.push("", "", "");
      } else if (fullLength < 9 && fullLength >= 5) {
        this.round2Matches.push("", "");
      } else if (fullLength < 5 && fullLength >= 3) {
        this.round2Matches.push("");
      }

      if (fullLength >= 5 && fullLength <= 8) {
        this.round3Matches.push("");
      }

      if (fullLength >= 9) {
        this.round4Matches.push("");
        this.round3Matches.push("", "");
      }

      return length;
    },
    ifOddMinusOne(length) {
      if (length % 2 === 1) {
        length--;
      }
      return length;
    },
    IfOddPlusOne(length) {
      if (length % 2 === 1) {
        length++;
      }
      return length;
    },
    sendThemHome() {
      this.$router.push("/");
    },
  },
};
</script>

<style>
/* .match:last-child .hide-this {
  display: none;
} */
#yep {
  width: 18%;
  height: 816px;
}
#yep1 {
  width: 20%;
  height: 816px;
}
#yep2 {
  width: 20%;
  height: 816px;
}
#yep3 {
  width: 20%;
}
#sp {
  width: 100%;
  height: 20%;
}
#sp2 {
  height: 75%;
}
img {
  height: 100%;
}
#sp3 {
  height: 100%;
}
.matchesround3 {
  margin-top: 5vh;
}
input[type="text"] {
  border-color: transparent;
}
#fork-round-3 {
}
/* input[type="text"]:hover{
  border-bottom:1px solid ;
}
*/
span {
  white-space: nowrap;
}
</style>
