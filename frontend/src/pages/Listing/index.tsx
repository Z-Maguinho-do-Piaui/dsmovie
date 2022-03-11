import Pagination from "components/Pagination";
import MovieCard from "components/MovieCard";
import axios from "axios";
import {useState, useEffect } from "react";
import { BASE_URL } from "utils/requests"
import { MoviePage } from "types/movie";


function Listing() {
    
    
    
    const [pageNumber, setPageNumber] = useState(0);

    // Assim ele não bate na api mais de uma vez por conta do useEffect não ter nenhum objeto para ele observar 
    useEffect(() => {
        axios.get(`${BASE_URL}/WeatherForecast`)
        .then(response => {
            const data = response.data as MoviePage
            setPageNumber(data.number);
        });
    }, []);

    

    // //FORMA ERRADA 
    //  axios.get(`${BASE_URL}/WeatherForecast`)
    //     .then(response => {
    //         console.log(response.data);
    //     });
    
    return (
        <>
            <p>{pageNumber}</p>
            <Pagination />
            <div className="container">
                <div className="row">
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                    <div className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                        <MovieCard />
                    </div>
                </div>
            </div>
        </>
    )
}

export default Listing;