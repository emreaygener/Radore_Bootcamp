import React, { Component } from "react";
import tutorialService from "../service/tutorial.service";
import { Link } from "react-router-dom";
export default class TutorialList extends Component {
  constructor(props) {
    super(props);

    //değişkenler nesneler arrayler saklanıyor
    this.state = {
      tutorials: [],
      currentTutorial: null,
      guncelIndex: -1,
      searchInput: "",
    };

    this.searchTitle = this.searchTitle.bind(this);
    this.searchOnChange = this.searchOnChange.bind(this);
    this.searchTitleByKeyUp = this.searchTitleByKeyUp.bind(this);
    this.AktifTutorial = this.AktifTutorial.bind(this);
  }

  //sayfa ilk yüklendiğinde çalışır
  componentDidMount() {
    console.log("Tutorial list sayfası yüklendi");
    this.tutoriallariGetir();
  }

  tutoriallariGetir() {
    tutorialService
      .getAll()
      .then((gelenYanit) => {
        this.setState({
          //rest apiden gelen veriye tutorial array ine aktardık
          tutorials: gelenYanit.data,
        });
        console.log(gelenYanit.data);
      })
      .catch((hata) => {
        console.log("hata oluştu : " + hata);
      });
  }

  searchOnChange = (e) => {
    this.setState({
      searchInput: e.target.value,
    });
  };

  searchTitle(e) {
    e.preventDefault();

    tutorialService.findByTitle(this.state.searchInput).then((response) => {
      this.setState({
        tutorials: response.data,
      });
      console.log(response.data);
    });
  }

  searchTitleByKeyUp(e) {
    e.preventDefault();
    setTimeout(() => {
      tutorialService.findByTitle(this.state.searchInput).then((response) => {
        this.setState({
          tutorials: response.data,
        });
        console.log(response.data);
      });
    }, 300);
  }

  AktifTutorial(tutorial, index) {
    console.log(tutorial);
    console.log(index);
    this.setState({
      currentTutorial: tutorial,
      guncelIndex: index,
    });
  }

  //body
  render() {
    const { tutorials, currentTutorial, guncelIndex, searchInput } = this.state;
    return (
      <div className="list row">
        <div className="col-md-8">
          <div className="input-group mb-3">
            <input
              type="text"
              className="form-control"
              placeholder="Başlığa göre ara"
              value={searchInput}
              onChange={this.searchOnChange}
              onKeyUp={this.searchTitleByKeyUp}
            />
            <div className="input-group-append">
              <button
                className="btn btn-success"
                onClick={this.searchTitle}
                type="button"
              >
                Ara
              </button>
            </div>
          </div>
        </div>
        <div className="col-md-6">
          <ul className="list-group">
            <h4>Tutorial Listesi</h4>

            {tutorials &&
              tutorials.map(
                (
                  tutorial,
                  index //tutorials array içindeki her bir elemanı tutorial nesnesi olarak kullandık
                ) => (
                  <li
                    className={
                      "list-group-item " +
                      (index === guncelIndex ? "active" : "")
                    }
                    onClick={() => this.AktifTutorial(tutorial, index)}
                    key={index}
                  >
                    {tutorial.title}
                  </li>
                )
              )}
          </ul>
        </div>
        <div className="col-md-6">
          {currentTutorial ? (
            <div>
              <h4>Tutarial Detay</h4>
              <div>
                <label>
                  <strong>Title : </strong>
                </label>{" "}
                {currentTutorial.title}
              </div>
              <div>
                <label>
                  <strong>Description : </strong>
                </label>{" "}
                {currentTutorial.description}
              </div>
              <Link
                to={"/tutorials/" + currentTutorial.id}
                className="btn btn-success"
              >
                Detaya Git
              </Link>
            </div>
          ) : (
            <p>Lütfen bir tutarial seçiniz.</p>
          )}
        </div>
      </div>
    );
  }
}
