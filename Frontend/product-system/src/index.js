import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import ResponsiveAppBar from './components/ResponsiveAppBar';

ReactDOM.render(
  <React.StrictMode>
    <ResponsiveAppBar />
    <div className='Container'>
      <App />
    </div>
  </React.StrictMode>,
  document.getElementById('root')
);

