import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  logging: {
    fetches: {
       fullUrl: true
    }
  }
};

module.exports = {
  typescript: {
    ignoreBuildErrors: true,
  },
  output: 'standalone',
  images: {
    remotePatterns: [
      {protocol: 'https', hostname: 'cdn.pixabay.com'}
    ]
  }
};

export default nextConfig;
