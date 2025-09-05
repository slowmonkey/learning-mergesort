FROM mcr.microsoft.com/dotnet/sdk:9.0

# Optional: install tools you want inside devcontainer
RUN apt-get update && apt-get install -y \
    git \
    curl \
    bash \
&& rm -rf /var/lib/apt/lists/*

RUN useradd -m vscode && \
    apt-get update && apt-get install -y sudo && \
    echo "vscode ALL=(ALL) NOPASSWD:ALL" >> /etc/sudoers

USER vscode