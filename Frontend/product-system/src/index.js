import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import BasicMenu from './components/BasicMenu';

ReactDOM.render(
  <React.StrictMode>
    <BasicMenu />
    <App />
  </React.StrictMode>,
  document.getElementById('root')
);

