import http from "../http-common";

class TutorialDataService {
  //http://85.159.71.66:8080/api/tutorials
  getAll() {
    //[{id:1,title:"title1",description:"description1"}]
    return http.get("/tutorials");
  }

  getDetail(id) {
    return http.get(`/tutorials/${id}`);
  }

  create(data) {
    return http.post("/tutorials", data);
  }

  update(id, data) {
    return http.put(`/tutorials/${id}`, data);
  }

  delete(id) {
    return http.delete(`/tutorials/${id}`);
  }

  deleteAll() {
    return http.delete(`/tutorials`);
  }

  findByTitle(title) {
    return http.get(`/tutorials?title=${title}`);
  }
}

export default new TutorialDataService();
