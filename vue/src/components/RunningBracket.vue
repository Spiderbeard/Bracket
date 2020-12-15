<template>
  <div class="tournament-margins">
    <div class="bracketVisualizer">
      <div>
        <h3>
          <u>Tournament Name: {{ this.$store.state.ActiveBracket.name }}</u>
        </h3>
        <span class="d-flex flex-row"
          ><p class="w-50">
            Number of Participants: {{ this.$store.state.Participants.length }}
          </p>
          <p>
            Number of matches:
            {{
              this.constuctMatches.length +
                this.round2Matches.length +
                this.round3Matches.length +
                this.round4Matches.length
            }}
          </p></span
        >
      </div>
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
                  <label class="team-input">
                    {{
                      teamsArray[index].name == ""
                        ? teamsArray[index].id
                        : teamsArray[index].name
                    }}
                  </label>
                </div>
              </span>
              <!-- <div>
                  <label for="Winner">Winner</label>
                  <input type="checkbox" v-model:>
              </div> -->
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
                    updatmatcharray(index);
                    teamsArray[teamsArray.length - index - 1].edit = false;
                    updatmatcharray;
                    $emit('update');
                  "
                />
              </span>
            </div>
          </div>
        </div>
        <div
          v-if="teamsArray.length > 2"
          class="d-flex flex-column justify-content-around round"
          :class="`round2` + teamsArray.length"
        >
          <div
            v-for="(round, index) in this.round2Matches"
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
            <fork
              v-if="round2Bys(index)"
              round="two"
              roundline="secondround"
              :length="teamsArray.length"
              :location="index"
            />
            <half-fork
              roundby="twoby"
              roundbyline="twolineby"
              :length="teamsArray.length"
              :location="index"
              v-else
            />
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
          v-if="round2Matches.length > 1"
          class="d-flex flex-column justify-content-around "
          :class="`round3` + teamsArray.length"
        >
          <div
            v-for="(round, index) in this.round3Matches"
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
            <fork
              v-if="round3Bys(index)"
              round="three"
              roundline="thirdround"
              :length="teamsArray.length"
              :location="index"
            />
            <half-fork
              roundby="threeby"
              roundbyline="threelineby"
              :length="teamsArray.length"
              :location="index"
              v-else
            />
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
          v-if="round4Matches.length === 1"
          class="d-flex flex-column justify-content-center "
          :class="`round4` + teamsArray.length"
        >
          <div
            v-for="(round, index) in this.round4Matches"
            v-bind:key="round.id"
            class="d-flex flex-column justify-content-center "
            id="sp3"
          >
            <!-- <img src="../assets/bracket.png" class=" pt-4 pb-4" alt="" /> -->
            <fork
              round="four"
              roundline="fourthround"
              :length="teamsArray.length"
              :location="index"
            />
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
          class="d-flex flex-column align-self-stretch justify-content-center "
          :class="`roundchamp` + teamsArray.length"
        >
          <div
            class="d-flex flex-column justify-content-center align-items-stretch "
            id="sp"
          >
            <champion-line class="d-flex " />
          </div>
        </div>
        <div
          class="CHAMPION d-flex flex-column justify-content-center "
          v-bind:class="` champ` + teamsArray.length"
        >
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
      <div class="button-margin">
        <button @click="updateActiveBracket">Add Teams</button>
      </div>
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

    HalfFork,
    ChampionLine,
  },
  created() {
    this.nextRoundMatches();
    this.buidMatchArray();
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
      wonIndex:
        this.constuctMatches.length +
        this.round2Matches.length +
        this.round3Matches.length +
        this.round4Matches.length,
      whatever: false,
      forkline: {
        round: "",
        line: "",
      },
      matchArray: [],
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
    updatmatcharray(index, name) {
      this.matchArray[index].name = name;
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
    isWinner() {},
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
    updateActiveBracket() {
      for (let i = 0; i < this.teamsArray.length - 1; i++) {
        this.matchArray[i].Participants1.name = this.teamsArray[i].name;
        this.matchArray[i + 1].Participants2.name = this.teamsArray[i + 1].name;
      }
      this.$store.commit("SET_BRACKET_PARTICIPANTS", this.teamsArray);
    },
    buidMatchArray() {
      for (let i = 0; i < this.wonIndex; i++) {
        this.matchArray.push(this.$store.state.match);
      }
    },
  },
};
</script>

<style>
.round216 {
  width: 23%;
  height: 816px;
}
.round316 {
  width: 16%;
  height: 816px;
}
.round416 {
  width: 22%;
  height: 816px;
}
.roundchamp16 {
  width: 19%;
}
.round215 {
  width: 27%;
  height: 816px;
}
.round315 {
  width: 22%;
  height: 816px;
}
.round415 {
  width: 22%;
  height: 816px;
}
.roundchamp15 {
  width: 25%;
}
.round214 {
  width: 23%;
  height: 816px;
}
.round314 {
  width: 18%;
  height: 816px;
}
.round414 {
  width: 22%;
  height: 816px;
}
.roundchamp14 {
  width: 22%;
}
.round213 {
  width: 26%;
  height: 816px;
}
.round313 {
  width: 23%;
  height: 816px;
}
.round413 {
  width: 22%;
  height: 816px;
}
.roundchamp13 {
  width: 22%;
}
.round212 {
  width: 23%;
  height: 816px;
}
.round312 {
  width: 16%;
  height: 816px;
}
.round412 {
  width: 22%;
  height: 816px;
}
.roundchamp12 {
  width: 21%;
}
.round211 {
  width: 23%;
  height: 816px;
}
.round311 {
  width: 16%;
  height: 816px;
}
.round411 {
  width: 22%;
  height: 816px;
}
.roundchamp11 {
  width: 20%;
}
.round210 {
  width: 23%;
  height: 816px;
}
.round310 {
  width: 16%;
  height: 816px;
}
.round410 {
  width: 22%;
  height: 816px;
}
.roundchamp10 {
  width: 20%;
}
.round29 {
  width: 23%;
  height: 816px;
}
.round39 {
  width: 16%;
  height: 816px;
}
.round49 {
  width: 22%;
  height: 816px;
}
.roundchamp9 {
  width: 21%;
}
.round28 {
  width: 23%;
  height: 816px;
}
.round38 {
  width: 21%;
  height: 816px;
}
.roundchamp8 {
  width: 25%;
  margin-top: 26px;
}
.round27 {
  width: 23%;
  height: 816px;
}
.round37 {
  width: 23%;
  height: 816px;
}
.roundchamp7 {
  width: 25%;
}
.round26 {
  width: 23%;
  height: 816px;
}
.round36 {
  width: 21%;
  height: 816px;
}
.roundchamp6 {
  width: 26%;
}
.round25 {
  width: 23%;
  height: 816px;
}
.round35 {
  width: 22%;
  height: 816px;
}
.roundchamp5 {
  width: 25%;
}
.round24 {
  width: 32%;
  height: 816px;
}

.roundchamp4 {
  width: 35%;
}
.round23 {
  width: 31%;
  height: 816px;
}

.roundchamp3 {
  width: 36%;
}
.roundchamp2 {
  width: 78%;
}
#sp {
  width: 100%;
  height: 20%;
}
#sp2 {
  height: 74%;
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
span {
  white-space: nowrap;
}
</style>
