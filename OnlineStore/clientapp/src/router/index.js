import Vue from "vue";
import VueRouter from "vue-router";

import vCatalog from "./../pages/v-catalog.vue";
import vAdminPanel from "./../pages/v-admin.vue";

Vue.use(VueRouter);

export default new VueRouter({
  routes: [
    {
      path: "/catalog",
      component: vCatalog,
    },
    {
      path: "/admin",
      component: vAdminPanel,
    },
  ],
});
