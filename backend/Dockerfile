# Build-Stage
FROM rust:latest AS builder

WORKDIR /app
COPY Cargo.toml Cargo.lock* ./
COPY src ./src
RUN cargo build --release

# Runtime-Stage
FROM debian:bookworm-slim

WORKDIR /app
COPY --from=builder /app/target/release/backend /app/backend

EXPOSE 8080
CMD ["./backend"]