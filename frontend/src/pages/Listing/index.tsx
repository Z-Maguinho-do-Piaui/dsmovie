import Pagination from "components/Pagination";
import MovieCard from "components/MovieCard";
import axios from "axios";
import { useState, useEffect } from "react";
import { BASE_URL } from "utils/requests"
import { MoviePage } from "types/movie";


function Listing() {

    //Estados 
    const [pageNumber, setPageNumber] = useState(1);
    const [page, setPage] = useState<MoviePage>({
        content: [],  
        last: true,
        totalPages: 0,
        totalElements: 0,
        size: 12,
        number: 0,
        first: true,
        numberOfElements: 0,
        empty: true
    });

    // Assim ele não bate na api mais de uma vez por conta do useEffect não ter nenhum objeto para ele observar 
    // useEffect(() => {
    //     axios.get(`${BASE_URL}/WeatherForecast&sort=id`)
    //         .then(response => {
    //             const data = response.data as MoviePage
    //             setPage(data);
    //         });
    // }, []);
    
    // useEffect(() => {
    //     axios.get(`${BASE_URL}/WeatherForecast`)
    //         .then(response => {
    //             const data = response.data as MoviePage
    //             console.log(data);
    //             setPage(data);
    //         });
    // }, [pageNumber]);

    useEffect(() => {
        axios.get(`${BASE_URL}/Movie/find-all?size=12&actualPage=${pageNumber}`)
            .then(response => {
                const data = response.data as MoviePage
                setPage(data);
            });
    }, [pageNumber]);

    // //FORMA ERRADA 
    //  axios.get(`${BASE_URL}/WeatherForecast`)
    //     .then(response => {
    //         console.log(response.data);
    //     });

    const handlePageChange = (newPageNumber : number) => {
        setPageNumber(newPageNumber);
    }

    return (

        // <p>Deu certo!</p>
        <>
            <Pagination page={page} onChange={handlePageChange} />
            <div className="container">
                <div className="row">
                    {page.content.map(movie => 
                        <div key={movie.id} className="col-sm-6 col-lg-4 col-xl-3 mb-3">
                            <MovieCard movie={movie} />
                        </div>
                    )}

                </div>
            </div>
        </>
    )
}

export default Listing;