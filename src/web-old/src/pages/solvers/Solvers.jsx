import { Switch, Route, Redirect, useRouteMatch, BrowserRouter, Link } from "react-router-dom";
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import TravelingSalesmanSolver from './TravelingSalesmanSolver';

export default function Solvers() {
  let { path, url } = useRouteMatch();
  return (
    <BrowserRouter>
      <Navbar bg="primary" variant="light" expand="lg">
        <Navbar.Brand>Solvers</Navbar.Brand>
        <Nav>
          <Nav.Item>
            <Link className="nav-link" to={path + "/traveling-salesman"}>Traveling Salesman</Link>
          </Nav.Item>
        </Nav>
      </Navbar>
      <Switch>
        <Route exact path={path}>
          <Redirect to={path + "/traveling-salesman"} />
        </Route>
        <Route exact path={path + "/traveling-salesman"} component={TravelingSalesmanSolver} />
      </Switch>
    </BrowserRouter>
  );
}
