import Vue from "vue";
import Vuex from "vuex";
import App from "./App.vue";
import router from "./router/index";
import { store } from "./store/index";
import vuetify from "@/plugins/vuetify"; // path to vuetify export

Vue.use(Vuex);

Vue.config.productionTip = false;

new Vue({
  store,
  router,
  vuetify,
  render: (h) => h(App),
}).$mount("#app");
