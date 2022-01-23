import axios from "axios";

const handleError = function(error) {
  if (error.response) {
    // Request made and server responded
    console.log(error.response.data);
    console.log(error.response.status);
    console.log(error.response.headers);
  } else if (error.request) {
    // The request was made but no response was received
    console.log(error.request);
  } else {
    // Something happened in setting up the request that triggered an Error
    console.log("Error", error.message);
  }
};

export const actions = {
  async PRODUCTS(context) {
    axios
      .get("products")
      .then((res) => context.commit("SET_PRODUCTS", res.data))
      .catch((err) => {
        handleError(err);
      });
  },
  async CATEGORIES(context) {
    axios
      .get("products/categories")
      .then((res) => context.commit("SET_CATEGORIES", res.data))
      .catch((err) => {
        handleError(err);
      });
  },
  async ADD_PRODUCT(context, data) {
    axios
      .post("products", data, {})
      .then((res) => context.commit("ADD_PRODUCT", res.data))
      .catch((err) => handleError(err));
  },

  async ADD_CATEGORY(context, data) {
    axios
      .post("products/category", data, {})
      .then((res) => {
        context.commit("ADD_CATEGORY", res.data);
      })
      .catch((err) => handleError(err));
  },
  async EDIT_CATEGORY(context, { item, id }) {
    axios
      .put(`products/category/${id}`, item, {})
      .then((res) =>
        context.commit("EDIT_CATEGORY", { category: res.data, id })
      )
      .catch((err) => handleError(err));
  },
  async DELETE_CATEGORY(context, id) {
    axios
      .delete(`products/category/${id}`)
      .then((res) => {
        context.commit("DELETE_CATEGORY", res.data);
      })
      .catch((err) => handleError(err));
  },
  async EDIT_PRODUCT(context, { item, id }) {
    axios
      .put(`products/${id}`, item, {})
      .then((res) => {
        context.commit("EDIT_PRODUCT", { product: res.data, id: id });
      })
      .catch((err) => handleError(err));
  },

  async DELETE_PRODUCT(context, id) {
    axios
      .delete(`products/${id}`)
      .then((res) => context.commit("DELETE_PRODUCT", res.data))
      .catch((error) => handleError(error));
  },

  async GET_PRODUCT_BY_CATEGORY(context) {
    axios
      .get("products", {
        params: { ID: 12345 },
      })
      .then((res) => context.commit("SET_PRODUCTS", res.data))
      .catch((err) => handleError(err));
  },
};
