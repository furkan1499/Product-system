import { BrowserRouter as Router, Route } from "react-router-dom";
import Container from '@mui/material/Container';
import ProductList from "./components/ProductList";

function App() {
  return (
    <>
    <Router>
      <Container maxWidth="sm">
        <Route exact path="/" component={ProductList} />
        {/* <Route path="/blogs/:id" component={BlogDetail} /> */}
      </Container>
    </Router>
    </>
  );
}

export default App;
