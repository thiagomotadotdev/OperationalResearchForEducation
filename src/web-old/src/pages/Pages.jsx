import Solvers from './solvers/Solvers';
import { Switch, Route, Redirect, BrowserRouter, useRouteMatch, Link } from "react-router-dom";
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

export default function Pages() {
  let { path, url } = useRouteMatch();
  console.log("Pages", path);
  return (
    <BrowserRouter>
      <Navbar bg="dark" variant="dark" expand="lg">
        <Navbar.Brand>OperationalResearchForEducation</Navbar.Brand>
        <Nav>
          <Nav.Item>
            <Link className="nav-link" to={path + "/solvers"}>Solvers</Link>
          </Nav.Item>
        </Nav>
      </Navbar>
      <Switch>
        <Route exact path={path}>
          <Redirect to={path + "/solvers"} />
        </Route>
        <Route exact path={path + "/solvers"} component={Solvers} />
      </Switch>
    </BrowserRouter>
  );
}