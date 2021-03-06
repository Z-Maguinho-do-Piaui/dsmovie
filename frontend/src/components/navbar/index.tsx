import { ReactComponent as GitHubIcon } from 'assets/img/github.svg';
import './styles.css'

function NavBar() {
  return (
    <header>
      <nav className="container">
        <div className="dsmovie-nav-content">
          <h1>DSMOVIE</h1>
          <a href="https://github.com/Z-Maguinho-do-Piaui/">
            <div className='dsmovie-contact-container'>
              <GitHubIcon />
              <p className='dsmovie-contact-link'>/Z-Maguinho-doPiaui</p>
            </div>
          </a>
        </div>
      </nav>
    </header>
  );
}

export default NavBar;