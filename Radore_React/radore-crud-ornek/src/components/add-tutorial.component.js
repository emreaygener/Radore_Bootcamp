import React, { Component } from "react";
import tutorialService from "../service/tutorial.service";

export default class AddTutorial extends Component {
  constructor(props) {
    super(props);
    this.state = {
      id: null,
      title: "",
      description: "",
      published: false,
    };

    this.onChangeTitle = this.onChangeTitle.bind(this);
    this.onChangeDescription = this.onChangeDescription.bind(this);
    this.kaydet = this.kaydet.bind(this);
  }

  onChangeTitle(e) {
    console.log(e.target.value);
    this.setState({
      title: e.target.value,
    });
  }

  onChangeDescription(e) {
    console.log(e.target.value);
    this.setState({
      description: e.target.value,
    });
  }

  kaydet() {
    console.log("kaydet tıklandı");
    var kaydedilecekTutorial = {
      title: this.state.title,
      description: this.state.description,
      published: false,
    };
    tutorialService
      .create(kaydedilecekTutorial)
      .then((kaydedilenTutorial) => {
        console.log(kaydedilecekTutorial.data);
        window.location.href = "/tutorials";
      })
      .catch((hata) => {
        console.log("hata oluştu : " + hata);
      });
  }

  render() {
    return (
      <div>
        <div className="submit-form">
          <div className="form-group">
            <label htmlFor="title">Title : </label>
            <input
              type="text"
              className="form-control"
              id="title"
              required
              onChange={this.onChangeTitle}
            ></input>
          </div>
          <br />
          <div className="form-group">
            <label htmlFor="description">Description : </label>
            <input
              type="text"
              className="form-control"
              id="description"
              onChange={this.onChangeDescription}
            ></input>
          </div>
          <br />
          <button className="btn btn-success" onClick={() => this.kaydet()}>
            Kaydet
          </button>
        </div>
      </div>
    );
  }
}
