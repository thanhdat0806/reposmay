const xhr = new XMLHttpRequest();

let xml = null;

xhr.open('get', '/data/QLKS_H2O.xml', false);

xhr.onload = function () {
  xml = this.responseXML;
};

xhr.send(null);

const xsltProcessor = new XSLTProcessor();

// Load the xsl file using synchronous (third param is set to false) XMLHttpRequest
const xhr2 = new XMLHttpRequest();
xhr2.open('get', '/data/trangthaiphong.xsl', false);

xhr2.onload = function () {
  xsltProcessor.importStylesheet(this.responseXML);

  const doc = xsltProcessor.transformToDocument(xml);

  const text = doc.firstElementChild.outerHTML;

  document.getElementById('main').innerHTML = text;

  document
    .getElementById('main')
    .querySelectorAll('button')
    .forEach((btn) => {
      btn.addEventListener('click', function () {
        // send to server
        axios
          .put('/vattu/trangthai', {
            phong: this.parentElement.parentElement.dataset.idphong,
            trangThai: this.parentElement.previousElementSibling
              .firstElementChild.value,
          })
          .then((res) => {
            if (res.data === 'OK') {
              location.reload();
            }
          })
          .catch((err) => {
            console.error(err.message);
          });
      });
    });
};

xhr2.send(null);
